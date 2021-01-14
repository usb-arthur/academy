<template>
  <div>
    <v-app-bar
      app
      absolute
      elevate-on-scroll
      scroll-target="#main"
      style="background-color: #28a7459c;"
    >
      <v-btn icon href="/">
        <v-icon>mdi-home</v-icon>
      </v-btn>
      <v-toolbar-title>ACADEMY</v-toolbar-title>
      <v-autocomplete
        v-model="select"
        :loading="loading"
        :items="items"
        :search-input.sync="search"
        cache-items
        class="mx-4"
        flat
        hide-no-data
        hide-details
        label="Bạn đang tìm kiếm gì ?"
        solo-inverted
      ></v-autocomplete>
      <v-spacer></v-spacer>
      <div class="mr-2" title="giỏ hàng">
        <v-btn icon>
          <span class="material-icons"> add_shopping_cart</span>
        </v-btn>
      </div>
      <div class="mr-2" title="khóa học">
        <v-btn icon>
          <span class="material-icons"> card_travel </span>
        </v-btn>
      </div>
      <div>
        <span style="font-family: serif">La Chi Thanh</span>
        <v-btn icon>
          <v-icon>mdi-account</v-icon>
        </v-btn>
      </div>
    </v-app-bar>
  </div>
</template>

<script>
export default {
  data: () => ({})
};
</script>

<style></style>
