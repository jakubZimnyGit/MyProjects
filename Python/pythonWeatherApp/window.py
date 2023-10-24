from tkinter import *
from tkinter import messagebox
import weather


font = ('Arial',10,'bold')
background = '#157de6'

def submit():
    input = text.get("1.0",END)
    cityName = input.capitalize()
    try:
         if __name__ == "__main__":
            Temperature, FeelsLike, Description = weather.get_current_weather(cityName)
            weatherInfo = Label(window,
                    text=f'Current Weather conditions in {cityName}\nTemperature: {Temperature} C, Feels like {FeelsLike} C\n{Description}',
                    font=font,
                    height=20,
                    width=40,
                    anchor='n',
                    bg= 'green')
            weatherInfo.pack()
            weatherInfo.place(x=400, y=130)
    except:
        messagebox.showerror(title="Invalid input", message="Please make sure the name of the city is correct and try again.")



window = Tk()
width = 800 
heigh = 650 
window.resizable(width=False, height=False)
ws = window.winfo_screenwidth() 
hs = window.winfo_screenheight() 


x = (ws/2) - (width/2)
y = (hs/2) - (heigh/2)


window.geometry('%dx%d+%d+%d' % (width, heigh, x, y))

window.title("Python Weather App")
icon = PhotoImage(file='logo.png')
window.iconphoto(True, icon)

window.config(bg= background)

Title = Label(window,
              text='Python Weather App',
              font=('Arial',40,'bold'),
              bg='#157de6',
              )
Title.pack()

inputLabel = Label(window,
                   text='City: ',
                   font=font,
                   bg=background
                   )
inputLabel.pack()
inputLabel.place(x=160 ,y=150 )

button = Button(window,
                height=2,
                width=20,
                text="Submit",
                font=font,
                command=submit,
                bg='green',
                activebackground='green'
                )
button.pack()
button.place(x=200,y=200)

text = Text(window,
            height=1,
            width=20,
            )
text.pack()
text.place(x=200,y=150)



window.mainloop()




