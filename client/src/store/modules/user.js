//import shop from '../../api/shop'

// initial state
// shape: [{ id, quantity }]
const state = () => ({
  items: [
    {
      id: 1,
      name: "AAAAAAAAAAA",
      mota: "ABCDXYZ DASDWDSFDGFDGFDGFD DSAD ASDAS DAS DAS DASD ASD SA",
      role: "GV",
      active: true
    },
    {
      id: 2,
      name: "BBBBBBBBBBB",
      mota: "ABCDXYZ DASDWDSFDGFDGFDGFD DSAD ASDAS DAS DAS DASD ASD SA",
      role: "HV",
      active: true
    },
    {
      id: 3,
      name: "CCCCCCCCCCC",
      mota: "ABCDXYZ DASDWDSFDGFDGFDGFD DSAD ASDAS DAS DAS DASD ASD SA",
      role: "HV",
      active: true
    },
    {
      id: 4,
      name: "DDDDDDDDDDD",
      mota: "ABCDXYZ DASDWDSFDGFDGFDGFD DSAD ASDAS DAS DAS DASD ASD SA",
      role: "HV",
      active: true
    },
    {
      id: 5,
      name: "EEEEEEEEEEE",
      mota: "ABCDXYZ DASDWDSFDGFDGFDGFD DSAD ASDAS DAS DAS DASD ASD SA",
      role: "GV",
      active: true
    }
  ]
});

// getters
const getters = {
  ACatalog: state => {
    return state.items.filters(catalog => catalog.active);
  }
};

// actions
const actions = {};

// mutations
const mutations = {};

export default {
  namespaced: true,
  state,
  getters,
  actions,
  mutations
};
