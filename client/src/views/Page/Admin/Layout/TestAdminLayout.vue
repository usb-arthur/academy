<template>
  <div>
    <v-app>
      <v-card>
        <v-navigation-drawer app floating permanent>
          <v-list dense color="primary" dark>
            <v-list-item>
              <v-list-item-content>
                <v-list-item-title>
                  <h3 class="font-weight-thin">ADMIN DASHBOARD</h3>
                </v-list-item-title>
              </v-list-item-content>
            </v-list-item>
          </v-list>
          <v-list-item>
            <v-list-item-avatar>
              <v-icon>mdi-account-outline</v-icon>
            </v-list-item-avatar>
            <v-list-item-content class="text-truncate">
              USER NAME PLACEHOLDING
            </v-list-item-content>
          </v-list-item>
          <v-divider></v-divider>
          <v-list>
            <v-list-item
              v-for="item in this.$store.state.paths.items"
              :key="item.title"
              link
              :to="item.href"
            >
              <v-list-item-icon>
                <v-icon
                  style="display: inline-block;text-decoration:none;"
                  color="primary"
                  >{{ item.icon }}</v-icon
                >
              </v-list-item-icon>
              <v-list-item-content
                style="display: inline-block;text-decoration:none;"
              >
                <v-list-item-title
                  style="display: inline-block;text-decoration:none;"
                  class="primary--text"
                  >{{ item.title }}</v-list-item-title
                >
              </v-list-item-content>
            </v-list-item>
          </v-list>
        </v-navigation-drawer>
      </v-card>
      <v-main>
        <v-container class="px-4 py-0 fill-height" fluid>
          <v-row class="fill-height">
            <v-col>
              <router-view></router-view>
            </v-col>
          </v-row>
        </v-container>
      </v-main>
    </v-app>
  </div>
</template>

<style>
html,
body {
  height: 100%;
  margin: 0;
}

.full-height {
  height: 100%;
}
</style>

<script>
export default {};
</script>
