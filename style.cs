
@import url('https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap');

* {
    padding: 0;
    margin: 0;
    box-sizing: border-box;
}

body {
    font-family: 'Roboto', sans-serif;
    background-color: #f2f4f6;
    margin: 0;
    padding: 0;
}

h1 {
    font-size: 75px;
    color: #0F9D58;
}

.container {
    display: flex;
    flex-direction: column;
    height: 100vh;
}

#heading-container {
    margin-top: 70px;
    margin-bottom: 30px;
    display: flex;
    justify-content: center;
    letter-spacing: 8px;
    font-style: italic;
    width: 100%;
}

#main-container {
    display: flex;
    justify-content: center;
    flex-direction: row;
    width: 100%;
}

.box {
    background-color: #fff;
    width: 375px;
    height: 350px;
    box-shadow: 0 1px 3px 0 rgba(0, 0, 0, .14);
    margin: 10px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    text-align: center;
}

.box .heading {
    display: flex;
    align-items: center;
    justify-content: center;
    height: 70px;
    width: 100%;
    border-bottom: 1px solid #e3e8ec;
}

.box h2 {
    color: #0F9D58;
}

.box #controls {
    width: 100%;
    height: 90%;
}

.box #controls .row {
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    border-bottom: 1px solid #e3e8ec;
}

.box #controls .row:first-child div {
    display: flex;
    justify-content: flex-start;
    align-items: center;
    flex-grow: 1;
    height: 30px;
    width: 100%;
}

#encode,
#decode {
    margin: 10px;
}

input[type="radio"]:checked+label {
    color: #0F9D58;
}

.box #controls .row:first-child div:last-child {
    border-left: 1px solid #e3e8ec;
}

.box #controls .row:nth-child(2) div {
    display: flex;
    flex-direction: row;
    color: #90999e;
    font-weight: 500;
    height: fit-content;
    width: 100%;
    padding-top: 5px;
}

.box #controls .row:nth-child(2) div div {
    padding-bottom: 10px;
}

.box #controls .row:nth-child(2) div span {
    margin-left: 10px;
}

#shift-input,
#mod-input {
    align-self: center;
    text-align: center;
    width: 40px;
    border: 0;
    outline: none;
    font-size: 14px;
}

.box #controls .row:nth-child(2) div:last-child {
    border-left: 1px solid #e3e8ec;
}

.box #controls .column div {
    display: flex;
    flex-direction: column;
    color: #90999e;
    font-weight: 500;
    height: fit-content;
    width: 100%;
    padding-top: 15px;

}

.box #controls .column div:last-child {
    border-bottom: 1px solid #e3e8ec;
    padding-bottom: 15px;
}

.box #controls .column div:last-child {
    padding-top: 8px;
}


#alphabet-input {
    align-self: center;
    text-align: center;
    width: 90%;
    border: 0;
    outline: none;
    font-size: 16px;
}

.box #controls .row:nth-child(4) div {
    display: flex;
    flex-direction: column;
    color: #90999e;
    font-weight: 500;
    height: fit-content;
    width: 100%;
    padding: 5px;
    text-align: left;
}

.box #controls .row:nth-child(4) div:last-child {
    border-left: 1px solid #e3e8ec;
}

select {
    border: 0;
    padding: 5px;
    outline: 0;
    font-size: 16px;
}

#submit {
    cursor: pointer;
    outline: 0;
    display: inline-block;
    font-weight: 400;
    margin: 15px 0px 20px 0px;
    line-height: 1.5;
    text-align: center;
    background-color: transparent;
    border: 1px solid transparent;
    padding: 6px 24px;
    font-size: 1rem;
    border-radius: .25rem;
    transition: color .15s ease-in-out, background-color .15s ease-in-out, border-color .15s ease-in-out, box-shadow .15s ease-in-out;
    color: #fff;
    background-color: #0F9D58;
    border-color: #0F9D58;
}

#submit:hover {
    background-color: #11ab61;
    border-color: #11ab61;
}

.box textarea {
    width: 100%;
    height: 90%;
    padding: 15px;
    font-size: 14px;
    box-sizing: border-box;
    resize: none;
    border: none;
    outline: none;
}
