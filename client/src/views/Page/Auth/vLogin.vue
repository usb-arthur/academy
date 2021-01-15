<template>
  <div class="center max-height max-width main">
    <div class="center max-height">
      <div class="box--login center">
        <div class="form--login">
          <div class="center">
            <span class="box__login--title">Đăng nhập</span>
          </div>
          <div>
            <v-text-field
              v-model="user.email"
              label="Email"
              type="email"
              append-icon="mdi-email"
              color="blue-grey lighten-3"
            ></v-text-field>
            <v-text-field
              v-model="user.password"
              label="Mật khẩu"
              :rules="{
                required: true,
                digits: 7,
                regex: '^(71|72|74|76|81|82|84|85|86|87|88|89)\\d{5}$',
              }"
              type="password"
              append-icon="mdi-lock"
              color="blue-grey lighten-3"
            ></v-text-field>
          </div>
          <div style="display: flex; justify-content: space-between">
            <router-link>
              <a class="link-forgot">Quên mật khẩu ?</a>
            </router-link>
            <router-link to="/dang-ky">
              <a class="link-forgot">Đăng ký ?</a>
            </router-link>
          </div>
          <div class="center">
            <v-btn class="btn-submit mr-4 mt-4" v-on:click="loginJWT(user)">
              Đăng nhập
            </v-btn>
          </div>
          <div>
            <v-checkbox
              v-model="user.rememberMe"
              label="Lưu đăng nhập"
              required
            ></v-checkbox>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { createNamespacedHelpers } from "vuex";
const { mapActions } = createNamespacedHelpers("auth");
export default {
  data: () => ({
    user: {
      email: "",
      password: "",
      rememberMe: false,
    },
  }),
  methods: {
    ...mapActions(["loginJWT"]),
  },
};
</script>

<style>
.main {
  background-image: url("../../../assets/image/backround-login.svg");
  background-size: 100%;
}
.max-height {
  height: 100%;
}
.max-width {
  width: 100%;
}
.center {
  display: flex;
  justify-content: center;
  align-items: center;
  align-self: center;
}
.box-center {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  align-self: center;
}
.box--login {
  width: 700px;
  height: 470px;
  border: 1px solid red;
  background: rgba(255, 255, 255, 0.2);
  border-radius: 20px;
}
.form--login {
  width: 540px;
  height: 360px;
}
.box__login--title {
  font-family: Roboto;
  font-style: normal;
  font-weight: normal;
  font-size: 35px;
  line-height: 47px;
  color: rgb(0 0 0 / 53%);
}
.btn-submit {
  height: 69px;
  width: 325px;
  background-color: #8bcdb9 !important;
  border-radius: 30px !important;
}
.link-forgot {
  font-family: Roboto;
  font-style: normal;
  font-weight: normal;
  font-size: 16px;
  line-height: 29px;
  text-decoration-line: underline;
  color: #259843;
}
.span-login-bottom {
  font-family: Roboto;
  font-style: normal;
  font-weight: normal;
  font-size: 16px;
  line-height: 29px;
}
.icon-login {
  width: 35px !important;
  height: 35px !important;
  size: 20px;
  cursor: pointer;
}
@media only screen and (max-width: 900px) {
  .box--login {
    width: 350px;
  }
  .form--login {
    width: 200px;
  }
}
</style>
