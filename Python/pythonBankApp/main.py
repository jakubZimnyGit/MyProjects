from flask import Flask, redirect, url_for, render_template, request, session, flash
from datetime import timedelta
from flask_sqlalchemy import SQLAlchemy
import random
from dotenv import load_dotenv
import os


load_dotenv()
app = Flask(__name__)
app.secret_key = os.getenv("SECRET_KEY")
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///users.sqlite3'
app.config["SQLALCHEMY_TRACK_MODIFICATIONS"] = False
app.permanent_session_lifetime = timedelta(minutes=10)

db = SQLAlchemy(app)

def generateAccountNumber():
    accNumber = str(random.randint(0, 9**16-1)).zfill(16)
    foundUser = users.query.filter_by(acountNumber = accNumber).first()
    if not foundUser is None:
        generateAccountNumber()
    return accNumber

class users(db.Model):
        _id = db.Column("id", db.Integer, primary_key = True)
        name = db.Column(db.String(100))
        email = db.Column(db.String(100))
        password = db.Column(db.String(100))
        accountNumber = db.Column(db.String(100))
        balance = db.Column(db.Integer)

def assignUserValues(username, email, accountNumber, balance):
    session["username"] = username
    session["email"] = email
    session["accountNumber"] = accountNumber
    session["balance"] = balance

def clearSessionOnLogout():
    session.pop("email", None)
    session.pop("username", None)
    session.pop("accountNumber", None)
    session.pop("balance", None)



    def __init__(self, name, email, password):
        self.name = name
        self.email = email
        self.password = password
        self.accountNumber = str(random.randint(0, 9**16-1)).zfill(16)
        self.balance = 100

@app.route("/")
def home():
    return render_template('index.html')

@app.route("/Login", methods = ["POST", "GET"])
def login():
    if request.method == "POST":
        userEmail = request.form["email"]
        userPassword = request.form["password"]
        foundUser = users.query.filter_by(email = userEmail).first()
        if foundUser is not None:
            if foundUser.password == users.query.filter_by(password = userPassword).first().password:
                assignUserValues(foundUser.name, foundUser.email, foundUser.accountNumber, foundUser.balance)
                flash("Logged in succesfully!")
                return redirect(url_for("user"))
            flash("Wrong email or passworddd, try again")
            return render_template('login.html')
        else:
            flash("Wrong email or password, try again")
            return render_template('login.html')
    else:
        if "username" in session:
            flash("You are already logged in!", "info")
            return redirect(url_for("user"))
        
        return render_template('login.html')
    
@app.route("/User")
def user():
    if 'username' in session:
        return render_template('user.html', value=users.query.filter_by(name=session["username"]).first())
        
    else:
        flash("You are not logged in")
        return redirect(url_for("login"))
    
    
@app.route("/logout")
def logout():
    if "username" in session:
        clearSessionOnLogout()
        flash(f"You have been logged out.", "info")
    return redirect(url_for("login"))

@app.route("/Register", methods = ["POST", "GET"])
def register():
    if request.method == "POST":
        userName = request.form["name"]
        email = request.form["email"]
        password = request.form["password"]
        foundUser = users.query.filter_by(name=userName).first()
        foundEmail = users.query.filter_by(email=email).first()
        if not foundUser is None:
            flash("This Username is taken.", "info")
            return render_template('register.html')
        elif not foundEmail is None:
            flash("Account was already created with this email.", "info")
            return render_template('register.html')
        else:
            usr = users(userName, email, password)
            db.session.add(usr)
            db.session.commit()
            flash("Registered succesfully!")
            return redirect(url_for("login"))  
    else:
        if "username" in session:
            flash("You are already logged in!", "info")
            return redirect(url_for("user"))    
    return render_template('register.html')


@app.route("/transfer", methods = ["POST", "GET"])
def transfer():
    if request.method == "POST":
        sender = (users.query.filter_by(name=session["username"]).first())
        accNumber = request.form["accountNumber"]
        print(accNumber)
        recipient = (users.query.filter_by(accountNumber = accNumber).first())      
        if accNumber == "" or (request.form["money"])  == "":
            return render_template('transfer.html')
        
        moneyAmountToTransfer = int(request.form["money"])       
        if recipient is not None:
            if sender.balance >= moneyAmountToTransfer:
                sender.balance -= moneyAmountToTransfer
                recipient.balance += moneyAmountToTransfer
                db.session.commit()
                flash("Operation succesful")
                return render_template('user.html', value=users.query.filter_by(name=session["username"]).first())
            else:
                flash("not enough money", "info")
                return render_template('transfer.html')
        else:
            flash("invalid information", "info")
            return render_template('transfer.html')
    else:
        if "username" not in session:
            flash("Access denied", "info")
            return redirect(url_for(home)) 
        return render_template('transfer.html')



if __name__ == "__main__":
    with app.app_context():
        db.create_all()
    app.run(debug=True)

