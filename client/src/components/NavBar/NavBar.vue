<template>
  <v-card>
    <v-app-bar
      app
      color="white"
      elevate-on-scroll
      scroll-target="#scrolling-techniques-7"
    >
      <v-btn icon href="/">
        <v-icon>mdi-home</v-icon>
      </v-btn>
      <v-toolbar-title>
        <h2>ACADEMY</h2>
      </v-toolbar-title>

      <v-menu
        offset-y
        :close-on-content-click="false"
        :close-on-click="true"
        bottom
      >
        <template v-slot:activator="{ on, attrs }">
          <v-btn v-bind="attrs" v-on="on"> LĨNH VỰC </v-btn>
        </template>

        <v-list>
          <v-list-item v-for="category in categories" :key="category.id">
            <v-menu
              offset-x
              :close-on-content-click="false"
              open-on-hover
              bottom
            >
              <template v-slot:activator="{ on, attrs }">
                <v-btn v-bind="attrs" v-on="on" plain>
                  {{ category.categoryName }}
                </v-btn>
              </template>
              <v-list>
                <router-link
                  v-for="categorys in category.children"
                  :key="categorys.id"
                  :to="`/danh-sach-khoa-hoc/${categorys.id}`"
                >
                  <v-list-item>
                    <v-list-item-title
                      v-text="categorys.categoryName"
                    ></v-list-item-title>
                  </v-list-item>
                </router-link>
              </v-list>
            </v-menu>
          </v-list-item>
        </v-list>
      </v-menu>

      <v-spacer></v-spacer>

      <v-btn icon>
        <v-icon>mdi-magnify</v-icon>
      </v-btn>

      <v-btn icon>
        <v-icon>mdi-heart</v-icon>
      </v-btn>

      <v-btn icon>
        <v-icon>mdi-dots-vertical</v-icon>
      </v-btn>
    </v-app-bar>
  </v-card>
</template>

<script>
export default {
  data() {
    return {
      categories: [],
    };
  },
  components: {},
  computed: {
    dslinhvucs() {
      return this.$store.state.categories.categories;
    },
  },
  async created() {
    await this.$store
      .dispatch("categories/getAllCategories")
      .then(() => {
        this.categories = this.dslinhvucs;
      })
      .catch((err) => console.log(err));
  },
};
</script>
