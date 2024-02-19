*** Settings ***
Library    RequestsLibrary

*** Variables ***
${base_url}     https://api.openweathermap.org/
${base_url_Post}    http://127.0.0.1:5000/
${city}     London
${KEY}  {API_KEY}

*** Test Cases ***
Get_weatherInfo
    Create Session    mySession     ${base_url}
    ${response} =   GET On Session    mySession    url= data/2.5/weather?appid=${KEY}&q=${city}&units=metric
    ${status_code}=     convert to string   ${response.status_code}
    Should be equal    ${status_code}   200
    #Log to console    ${response.content}
    ${body}=    convert to string   ${response.content}
    Should contain    ${body}   pressure

Register an account (POST)
    Create Session    mySession    ${base_url_Post}
    ${body}=    Create dictionary   name=jakub  email=jakub@gmail.com   password=jakub26
    ${header}=  Create dictionary    Content-Type=application/json
    ${response}=    POST On Session    mySession    /Register    data=${body}    headers=${header}

    Log to console    ${response.status_code}
    Log to console    ${response.content}

