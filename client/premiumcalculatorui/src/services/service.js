import axios from 'axios'

// const calculate = (age, amount, occupation) => {
//     console.log(`inputs amount is:${amount}`)
//     return axios
//         .get(`http://localhost:63690/api/premium?age=${age}&amount=${amount}&occupation=${occupation}`)
//}


        const calculate = async (age, amount, occupation) => {
            console.log(`inputs amount is:${amount}`)

            const response1 = await axios
            .get(`https://fakestoreapi.com/products/1`)
            .catch(error => {
                console.log('Error', error)
            });
            console.log(response1.data)

            const response = await axios
            .get(`http://localhost:63690/api/premium?age=${age}&amount=${amount}&occupation=${occupation}`)
                .catch(error => {
                    console.log('Error', error)
                });
            console.log(response.data)
            return calculate
        }



const premiumService = {
    calculate
};

export default premiumService;