*** Settings ***
Library    RequestsLibrary

*** Variables ***
${base_url}     https://api.openweathermap.org/
${city}     London
${KEY}  <API_KEY>

*** Test Cases ***
Get_weatherInfo
    Create Session    mySession     ${base_url}
    ${response} =   GET On Session    mySession    url= data/2.5/weather?appid=${KEY}&q=${city}&units=metric
    ${status_code}=     convert to string   ${response.status_code}
    Should be equal    ${status_code}   200
    #Log to console    ${response.content}
    ${body}=    convert to string   ${response.content}
    Should contain    ${body}   pressure


