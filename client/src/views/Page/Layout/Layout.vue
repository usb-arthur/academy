<template>
  <v-app>
    <v-app-bar app absolute elevate-on-scroll scroll-target="#main">
      <v-app-bar-nav-icon @click="drawer = true"></v-app-bar-nav-icon>
      <v-toolbar-title>Giảng viên</v-toolbar-title>
      <v-spacer></v-spacer>

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

      <v-btn icon>
        <v-icon>mdi-heart</v-icon>
      </v-btn>

      <v-btn icon>
        <v-icon>mdi-dots-vertical</v-icon>
      </v-btn>
    </v-app-bar>
    <v-navigation-drawer absolute temporary v-model="drawer">
<!--      <v-list-item-group-->
<!--        v-model="group"-->
<!--        active-class="deep-purple&#45;&#45;text text&#45;&#45;accent-4"-->
<!--      >-->
<!--        <router-link to="/">-->
<!--          <v-list-item>-->
<!--            <v-list-item-icon>-->
<!--              <v-icon>mdi-home</v-icon>-->
<!--            </v-list-item-icon>-->
<!--            <v-list-item-title>Home</v-list-item-title>-->
<!--          </v-list-item>-->
<!--        </router-link>-->
<!--        <router-link to="/giang-vien/khoa-hoc">-->
<!--          <v-list-item>-->
<!--            <v-list-item-icon>-->
<!--              <v-icon>mdi-account</v-icon>-->
<!--            </v-list-item-icon>-->
<!--            <v-list-item-title>Courses</v-list-item-title>-->
<!--          </v-list-item>-->
<!--        </router-link>-->
<!--        <router-link to="/thong-tin-ca-nhan">-->
<!--          <v-list-item>-->
<!--            <v-list-item-icon>-->
<!--              <v-icon>mdi-account</v-icon>-->
<!--            </v-list-item-icon>-->
<!--            <v-list-item-title>Tài khoản</v-list-item-title>-->
<!--          </v-list-item>-->
<!--        </router-link>-->
<!--      </v-list-item-group>-->




      <v-list>
        <router-link to="/">
          <v-list-item>
            <v-list-item-icon>
              <v-icon>mdi-home</v-icon>
            </v-list-item-icon>
            <v-list-item-title>Home</v-list-item-title>
          </v-list-item>
        </router-link>
        <router-link to="/thong-tin-ca-nhan">
          <v-list-item>
            <v-list-item-icon>
              <v-icon>mdi-account</v-icon>
            </v-list-item-icon>
            <v-list-item-title>Tài khoản</v-list-item-title>
          </v-list-item>
        </router-link>
        <router-link to="/giang-vien/khoa-hoc">
          <v-list-item>
            <v-list-item-icon>
              <v-icon>mdi-account</v-icon>
            </v-list-item-icon>
            <v-list-item-title>Courses</v-list-item-title>
          </v-list-item>
        </router-link>

        <v-list-group
            :value="true"
            prepend-icon="mdi-account-circle"
        >
          <template v-slot:activator>
            <v-list-item-title>Users</v-list-item-title>
          </template>

          <v-list-group
              :value="true"
              no-action
              sub-group
          >
            <template v-slot:activator>
              <v-list-item-content>
                <v-list-item-title>Admin</v-list-item-title>
              </v-list-item-content>
            </template>

            <v-list-item
                v-for="([title, icon], i) in admins"
                :key="i"
                link
            >
              <v-list-item-title v-text="title"></v-list-item-title>

              <v-list-item-icon>
                <v-icon v-text="icon"></v-icon>
              </v-list-item-icon>
            </v-list-item>
          </v-list-group>

          <v-list-group
              no-action
              sub-group
          >
            <template v-slot:activator>
              <v-list-item-content>
                <v-list-item-title>Actions</v-list-item-title>
              </v-list-item-content>
            </template>

            <v-list-item
                v-for="([title, icon], i) in cruds"
                :key="i"
                link
            >
              <v-list-item-title v-text="title"></v-list-item-title>

              <v-list-item-icon>
                <v-icon v-text="icon"></v-icon>
              </v-list-item-icon>
            </v-list-item>
          </v-list-group>
        </v-list-group>
      </v-list>
    </v-navigation-drawer>
    <v-main id="main">
      <router-view></router-view>
    </v-main>
  </v-app>
</template>

<script>
export default {
  data: () => ({
    drawer: false,
    group: null
  })
};
</script>
