<template>
  <li v-bind:class="[catalog.active ? 'done' : '']">
    {{ catalog.catalogname }}
    <button v-if="catalog.active" class="">Delete</button>
  </li>
</template>

<script>
export default {
  name: "linhvuc",
  props: ["catalog"]
};
</script>
