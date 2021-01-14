<template>
  <div>
    <v-app-bar
      app
      absolute
      elevate-on-scroll
      scroll-target="#main"
      style="background-color: #28a7459c"
    >
      <v-btn icon to="/">
        <v-icon>mdi-home</v-icon>
      </v-btn>
      <v-toolbar-title>ACADEMY</v-toolbar-title>
      <v-menu offset-y>
        <template v-slot:activator="{ on, attrs }">
          <v-btn text light v-bind="attrs" v-on="on">Danh sách lĩnh vực</v-btn>
        </template>
        <v-list dense nav>
          <v-list-item
            link
            :to="`/danh-sach-khoa-hoc/${category.id}`"
            v-for="category in categories"
            :key="category.id"
          >
            <v-list-item-content>
              <v-menu style="width: 100%" offset-x open-on-hover>
                <template v-slot:activator="{ on, attrs }">
                  <v-btn text light v-bind="attrs" v-on="on">{{
                    category.categoryName
                  }}</v-btn>
                </template>
                <v-list light dense nav>
                  <v-list-item
                    v-for="child in category.children"
                    :key="child.id"
                    link
                    :to="`/danh-sach-khoa-hoc/${child.id}`"
                  >
                    <v-list-item-content>
                      <v-list-item-title>{{
                        child.categoryName
                      }}</v-list-item-title>
                    </v-list-item-content>
                  </v-list-item>
                </v-list>
              </v-menu>
            </v-list-item-content>
          </v-list-item>
        </v-list>
      </v-menu>
      <v-autocomplete
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
      <router-link v-if="has('teacher')" to="/giang-vien/khoa-hoc">
        <div class="mr-2" title="khóa học">
          <v-btn icon>
            <span class="material-icons"> card_travel </span>
          </v-btn>
        </div>
      </router-link>
      <v-menu v-if="isAuthenticated()" offset-y open-on-hover>
        <template v-slot:activator="{ on, attrs }">
          <v-btn text light v-bind="attrs" v-on="on">{{ userInfo() }}</v-btn>
        </template>
        <v-list light dense nav>
          <v-list-item link to="/thong-tin-ca-nhan">
            <v-list-item-content>
              <v-list-item-title>Thông tin cá nhân</v-list-item-title>
            </v-list-item-content>
          </v-list-item>
          <v-divider></v-divider>
          <v-list-item @click="logout()">
            <v-list-item-content>
              <v-list-item-title>Đăng xuất</v-list-item-title>
            </v-list-item-content>
          </v-list-item>
        </v-list>
      </v-menu>
      <v-btn v-else text light link to="/dang-nhap">Đăng nhập</v-btn>
    </v-app-bar>
  </div>
</template>

<script>
import { mapActions, mapState } from "vuex";
export default {
  data: () => ({}),
  computed: {
    ...mapState("auth", ["has", "userInfo", "isAuthenticated"]),
    ...mapState("category", ["categories"]),
  },
  created() {
    this.getAllCategories();
  },
  methods: {
    ...mapActions("category", ["getAllCategories"]),
    ...mapActions("auth", ["logout"]),
  },
};
</script>

<style></style>
