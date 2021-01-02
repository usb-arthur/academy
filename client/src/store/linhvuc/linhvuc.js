//import shop from '../../api/shop'

// initial state
// shape: [{ id, quantity }]
const state = () => ({
  items: [
    { id: 1, catalogname: "IT", active: true },
    { id: 2, catalogname: "Design", active: true },
    { id: 3, catalogname: "Game", active: true },
    { id: 4, catalogname: "Database", active: true },
    { id: 5, catalogname: "Advanced", active: false }
  ]
});

// getters
const getters = {
  ACatalog: state => {
    return state.items.filter(catalog => catalog.active);
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
