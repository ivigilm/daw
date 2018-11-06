<?php

$euros = $_POST['euros'];
$pesetas = $euros * 166;
echo 'You have ' . $euros . ' euros, which is ' . $pesetas . ' pesetas.';