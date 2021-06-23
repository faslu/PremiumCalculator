import { actionTypes } from '../constants/actionTypes'
const initialState = {
    premium: '' //{}
}

export const premiumReducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.CALCULATE_PREMIUM:
            return { ...state, premium: action.payload };
        default:
            return state;
    }



}