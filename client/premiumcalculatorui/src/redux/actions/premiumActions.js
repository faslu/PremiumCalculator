import { actionTypes } from '../constants/actionTypes'
import  premiumService  from '../../services/service'

// export const premiumActions = {
//     calculate
// }

export const CalculatePremium = (age, amount, occupation) => async (dispatch) => {
    try {
        console.log(`inputs are:${occupation}`)
        const res = await premiumService.calculate( age, amount, occupation );
        console.log(res.data)
        dispatch({
            type: actionTypes.CALCULATE_PREMIUM,
            payload: res.data
        });
        return Promise.resolve(res.data);
    }
    catch (err) {
        return Promise.reject(err)
    }

};


