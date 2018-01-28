
function IsFirstNameEmpty() {
    if (document.getElementById('txtFName').value == "") {
        return 'First Name Should not be Empty';
    }
    else { return ""; }
}

function IsFirstNameInValid() {
    if (document.getElementById('txtFName').value.indexOf("@") != -1) {
        return 'First Name should not contain @';
    }
    else { return ""; }
}

function IsLastNameInValid() {
    if (document.getElementById('txtLName').value.length > 5) {
        return 'Last Name should Exceed 5 Length';
    }
    else { return ""; }
}

function IsSalaryEmpty() {
    if (document.getElementById('txtSalary').value == "") {
        return 'Salary should not be empty';
    }
    else { return ""; }
}

function IsSalaryInValid() {
    if (isNaN(document.getElementById('').value)) {
        return 'enter Valid Salary';
    }
    else { return ""; }
}

function IsValid() {
    debugger;
    var FirstNameEmptyMessage = IsFirstNameEmpty();
    var FirstNameInValidMessage = IsFirstNameInValid();
    var LastNameInValidMessage = IsLastNameInValid();
    var SalaryEmptyMessage = IsSalaryEmpty();
    var SalaryInvalidMessage = IsSalaryInValid();

    var FinalErrorMessage = "Errors:";
    if (FirstNameEmptyMessage != "")
        FinalErrorMessage += "\n" + FirstNameEmptyMessage;
    if (FirstNameInValidMessage != "")
        FinalErrorMessage += "\n" + FirstNameInValidMessage;
    if (LastNameInValidMessage != "")
        FinalErrorMessage += "\n" + LastNameInValidMessage;
    if (SalaryEmptyMessage != "")
        FinalErrorMessage += "\n" + SalaryEmptyMessage;
    if (SalaryInvalidMessage != "")
        FinalErrorMessage += "\n" + SalaryInvalidMessage;

    if (FinalErrorMessage != "Errors:") {
        alert(FinalErrorMessage);
        return false;
    }
    else {
        return true;
    }
}