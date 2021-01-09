export default {
  children: state => id => {
    const category = state.categories.find(e => e.id == id);
    return category == null ? [] : category.children;
  }
};
