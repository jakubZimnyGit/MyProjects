*** Settings ***
Library     SeleniumLibrary

*** Variables ***
${browser}    Chrome
${url}    https://demo.nopcommerce.com/
*** Test Cases ***
LoginTest
    Open browser    ${url}    ${browser}    options=add_experimental_option("detach", True)
    LoginToApplication


*** Keywords ***
loginToApplication
    Click link   xpath:/html/body/div[6]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a
    input text  id:Email  artur@gmail.com
    input text  id:Password    szpilka123
    Click element  xpath:/html/body/div[6]/div[3]/div/div/div/div[2]/div[1]/div[2]/form/div[3]/button