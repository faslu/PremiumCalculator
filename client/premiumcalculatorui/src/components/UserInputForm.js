import React, { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { CalculatePremium } from '../redux/actions/premiumActions'


const UserInputForm = () => {
    const [input, setInput] = useState({ userName: '', age: '', amount: '', occupation: '' })
    const [submitted, setSubmitted] = useState(false);
    const dispatch = useDispatch();

    const handleChange = (evt) => {
        const val = evt.target.value;
        setInput({
            ...input,
            [evt.target.name]: val
        })
        console.log([evt.target.name]);

    }

    const handleSubmit = (evt) => {

        evt.preventDefault();
        setSubmitted(true);
        console.log('dropdown'+input.occupation!='noselect');
        if (input.userName && input.age && (input.occupation!='noselect') && input.amount) {
        dispatch(CalculatePremium(input.age, input.amount, input.occupation))
            .then(data => {
                setSubmitted(true);
                // console.log(data);
            })

            .catch(e => {
                console.log(e)
            });
        }
    };




    return (
        <div className="col-lg-8 offset-lg-2">
            <h2>Calculate Premium</h2>
            <form name="form" onSubmit={handleSubmit}>
                <div className="form-group">
                    <label>Name</label>
                    <input type="text" name="userName" value={input.useName} onChange={handleChange} className={'form-control' + (submitted && !input.userName ? ' is-invalid' : '')} />
                    {submitted && !input.userName &&
                        <div className="invalid-feedback">Name is required</div>
                    }
                </div>
                <div className="form-group">
                    <label>Age</label>
                    <input type="text" name="age" value={input.age} onChange={handleChange} className={'form-control' + (submitted && !input.age ? ' is-invalid' : '')} />
                    {submitted && !input.age &&
                        <div className="invalid-feedback">Age is required</div>
                    }
                </div>
                <div className="form-group">
                    <label>Occupation</label>
                    <select name="occupation" value={input.occupation} onChange={handleChange} className={'form-control' + (submitted && !input.occupation ? ' is-invalid' : '')} >
                        <option value="noselect">Select Occupation</option>
                        <option value="cleaner">Cleaner</option>
                        <option value="doctor">Doctor</option>
                        <option value="author">Author</option>
                        <option value="farmer">Farmer</option>
                        <option value="mechanic">Mechanic</option>
                        <option value="florist">Florist</option>
                    </select>
                    {submitted && !(input.occupation==='noselect') &&
                        <div className="invalid-feedback">Occupation is required</div>
                    }
                </div>
                <div className="form-group">
                    <label>Amount</label>
                    <input type="text" name="amount" value={input.amount} onChange={handleChange} className={'form-control' + (submitted && !input.amount ? ' is-invalid' : '')} />
                    {submitted && !input.amount &&
                        <div className="invalid-feedback">Amount is required</div>
                    }
                </div>
                <div className="form-group">
                    <button className="btn btn-primary">

                        Calculate
                    </button>
                   
                </div>
            </form>
        </div>



    )

}

export default UserInputForm