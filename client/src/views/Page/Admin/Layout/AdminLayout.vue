<template>
  <div class="container-fluid full-height">
    <b-card>
      <b-container class="bv-example-row full-height" fluid>
        <b-row class="container-fluid vh-100" align-v="stretch">
          <b-col md="auto" class="border bg-info text-white text-center">
            <h5>
              MENU
            </h5>

            <b-nav vertical pills>
              <b-nav-item to="/admin/linhvuc" exact exact-active-class="active">
                <b-card class="text-black">
                  LINH VUC
                </b-card>
              </b-nav-item>
              <b-nav-item to="/admin/khoahoc" exact exact-active-class="active">
                <b-card>
                  KHOA HOC
                </b-card>
              </b-nav-item>
              <b-nav-item to="/admin/user" exact exact-active-class="active">
                <b-card>
                  NGUOI DUNG
                </b-card>
              </b-nav-item>
            </b-nav>
          </b-col>
          <b-col align-self="stretch" class="border">
            <router-view></router-view>
          </b-col>
        </b-row>
      </b-container>
    </b-card>
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
