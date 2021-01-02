<template>
  <div>
    <h3>Todo</h3>
    <ul id="array-with-index" class="demo">
      <LINHVUCITEM
        
        v-for="items in dslinhvucs"
        :key="items.id"
        v-bind:catalog="items"
      />
    </ul>
  </div>
</template>

<script>
import LINHVUCITEM from "./linhvuc.vue";
export default {
  name: "dslinhvuc",
  data: function() {
    return {};
  },
  props: ["list"],
  components: {
    LINHVUCITEM
  },
  methods: {},
  computed: {
    dslinhvucs() {
      return this.$store.state.linhvuc.items;
    }
  }
};
</script>


