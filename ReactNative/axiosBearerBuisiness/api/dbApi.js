import axios from 'axios';

export default axios.create({
    baseURL: 'https://api.yelp.com/v3/businesses',
    headers: {
        Authorization: 'Bearer P_RuCefu_yNsWlHZImH5b8t-GbisM8k1I4FM11h8pnXG2p4hvxdUxJJlz9-AbD6Ibp0kfRCrVUthLfuwIQceXdETvlhJ0gfm4m89h_6yL-J2jZePpCOVjzKReCdmZXYx'
    }
})