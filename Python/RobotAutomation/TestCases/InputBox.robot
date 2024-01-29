*** Settings ***
Library    SeleniumLibrary


*** Variables ***
${Browser}  chrome
${url}  https://demo.nopcommerce.com/


*** Test Cases ***
TestingInputBox
    Open browser    ${url}  ${Browser}  options=add_experimental_option("detach", True)
    Maximize browser window
    Title should be    nopCommerce demo store
    Click link    xpath:/html/body/div[6]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a
    ${"email.txt"}  Set variable    id:Email

    Element should be visible    ${"email.txt"}
    Element should be enabled    ${"email.txt"}

    Input text    ${"email.txt"}    artur@gmail.com
    sleep   5
    Clear element text    ${"email.txt"}
    sleep   3
    Close browser
*** Keywords ***
CheckingInputBox
