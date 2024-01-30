*** Settings ***
Library    SeleniumLibrary


*** Variables ***
${Browser}  chrome
${url}  https://demo.nopcommerce.com/register?returnUrl=%2F


*** Test Cases ***
Testing radio buttons and checkboxes
    Open browser    ${url}  ${Browser}
    HandleRadioButton
    Close browser

*** Keywords ***
HandleRadioButton
    Maximize browser window
    Select radio button    Gender  M
    sleep   2


