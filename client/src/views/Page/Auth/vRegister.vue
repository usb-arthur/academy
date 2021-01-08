<template>
  <div class="center max-height max-width main  ">
    <div class="center max-height">
      <div class="box--reg center">
        <div class="form--reg">
          <div class="center">
            <span class="box__reg--title">Đăng ký</span>
          </div>
          <div>
            <v-text-field
              v-model="email"
              label="Email"
              required
              type="email"
              append-icon="mdi-email"
            ></v-text-field>
            <v-text-field
              v-model="password"
              label="Mật khẩu"
              required
              type="password"
              append-icon="mdi-lock"
            ></v-text-field>
            <v-text-field
              v-model="password"
              label="Nhập lại mật khẩu"
              required
              type="password"
              append-icon="mdi-lock"
            ></v-text-field>
          </div>
          <div>
            <v-checkbox
              v-model="checkbox"
              label="Tôi đồng ý với các điều khoản của Udemy"
              required
            ></v-checkbox>
          </div>
          <div class="center">
            <v-btn class="btn-submit mr-4 mt-4" @click="submit">
              Đăng ký
            </v-btn>
          </div>
          <div class="mt-4">
            <span class="span-reg-bottom">Bạn đã có tài khoản</span>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {};
</script>

<style scoped>
.main {
  background-image: url("/src/assets/image/backround-reg.svg");
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
.box--reg {
  width: 700px;
  height: 470px;
  border: 1px solid red;
  background: rgba(255, 255, 255, 0.2);
  border-radius: 20px;
}
.form--reg {
  width: 540px;
  height: 400px;
}
.box__reg--title {
  font-family: Roboto;
  font-style: normal;
  font-weight: normal;
  font-size: 35px;
  line-height: 47px;
  color: red;
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
  color: #ffffff;
}
.span-reg-bottom {
  font-family: Roboto;
  font-style: normal;
  font-weight: normal;
  font-size: 16px;
  line-height: 29px;
}
.icon-reg {
  width: 35px !important;
  height: 35px !important;
  size: 20px;
}
@media only screen and (max-width: 900px) {
  .box--reg {
    width: 450px;
  }
}
</style>
